appModule.controller('funcionarioController', function ($scope, $http, $location,$window, $modal, Api) {
    $scope.requisicao = {};
    $scope.dependentes = [];
    $scope.usuarios = Api.Usuario.query();
    $scope.assuntos = Api.Assunto.query();
    $scope.instrucoes = Api.GrauInstrucao.query();

    $scope.add = function () {
        $scope.requisicao.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.requisicao.tipo_requisicao = 'funcionario';
        $scope.requisicao.recursos = $scope.logins;
        $scope.requisicao.grau_instrucao = $scope.instrucao.grau_instrucao_id;
        Api.Requisicao.save($scope.requisicao).$promise.then(function () {
            Api.Notificacao('Sucesso','Requisição adicionada com sucesso.');
            $scope.requisicao = null;
        }, function () {
            Api.Notificacao('Erro', 'Ocorreu um erro. Verifique as informações e tente novamente.');
        });
    };

    $scope.login = '';
    $scope.logins = [];
    $scope.deleteTag = function (index) {
        if ($scope.logins != null && $scope.logins.length > 0) {
            $scope.logins.splice(index, 1);
        }
    };

    $scope.addTag = function ($event) {
        $scope.logins.push($scope.login)
        $scope.login = '';
    };
    $scope.requisicao.dependentes = [];
    $scope.open = function () {
        var modalInstance = $modal.open({
            templateUrl: 'dependente.html',
            controller: dependenteController
        });
        
        modalInstance.result.then(function (dependente) {
            $scope.requisicao.dependentes.push(dependente);
            dependente = null;
        });
    };

    $scope.getEndereco = function () {
        $scope.requisicao.cep = $scope.requisicao.cep.replace('.', '').replace('-', '');
        if ($scope.requisicao.cep.length == 8) {
            $http.get('http://cep.correiocontrol.com.br/' + $scope.requisicao.cep + '.json').
                success(function (data) {
                    $scope.requisicao.endereco = data.logradouro;
                    $scope.requisicao.bairro = data.bairro;
                    $scope.requisicao.uf = data.uf;
                    $scope.requisicao.municipio = data.localidade;
                });
        }
    }

    this.columns =
        [
            { field: 'nascimento', width: 120, displayName: 'Nascimento', cellFilter: 'date' },
            { field: 'nome', width: 250, displayName: 'Nome' },
            { field: 'anotacao', width: 500, displayName: 'Anotação' }
        ]

    $scope.gridDependentes = {
        data: 'requisicao.dependentes',
        columnDefs: this.columns,
        multiSelect: false,
        i18n: 'pt-br'
    };
});

var dependenteController = function ($scope, $modalInstance) {
    $scope.dependente = {};
    $scope.ok = function () {
        $modalInstance.close($scope.dependente);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
}