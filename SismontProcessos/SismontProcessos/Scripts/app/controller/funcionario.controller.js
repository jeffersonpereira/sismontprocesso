appModule.controller('funcionarioController', function ($scope, $http, $window, $modal, Api) {
    $scope.funcionario = {};
    $scope.dependentes = [];
    Api.Usuario.query(function (data) {
        $scope.usuarios = data;
    });
    Api.Assunto.query(function (data) {
        $scope.assuntos = data;
    })

    $scope.add = function () {
        $scope.funcionario.tipo = $scope.tipo;
        $scope.funcionario.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.funcionario.tipo_requisicao = 'funcionario';
        $scope.funcionario.recursos = $scope.logins;
        Api.Requisicao.save($scope.funcionario).$promise.then(function () {
            $window.location.href += "Requisicao";
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

    $scope.open = function () {
        var modalInstance = $modal.open({
            templateUrl: 'dependente.html',
            controller: dependenteController
        });

        modalInstance.result.then(function (dependente) {
            $scope.funcionario.dependentes.push(dependente);
            dependente = null;
        });
    };

    $scope.getEndereco = function () {
        if ($scope.funcionario.cep.length == 8) {
            $http.get('http://cep.correiocontrol.com.br/' + $scope.funcionario.cep + '.json').
                success(function (data) {
                    $scope.funcionario.endereco = data.logradouro;
                    $scope.funcionario.bairro = data.bairro;
                    $scope.funcionario.uf = data.uf;
                    $scope.funcionario.municipio = data.localidade;
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
        data: 'funcionario.dependentes',
        columnDefs: this.columns,
        multiSelect: false,
        i18n: 'pt-br'
    };
});

var dependenteController = function ($scope, $modalInstance) {
    $scope.dependente = {nome:'',nascimento:'',tipo:'',parentesco:'',sexo:'',cpf:''};
    $scope.ok = function () {
        $modalInstance.close($scope.dependente);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
}