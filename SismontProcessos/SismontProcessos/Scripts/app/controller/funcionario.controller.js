var appModule = angular.module('app', ['ngResource', 'ngGrid', 'ui.bootstrap']);


appModule.controller('funcionarioController', function ($scope, $modal, requisicaoFactory, assuntoFactory) {

    assuntoFactory.query(function (data) {
        $scope.assuntos = data;
    })

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

    $scope.dependentes = [{ nome: 'Perla Chaves Soares da Silva', nascimento: '16/09/2007' }, { nome: 'Mara Cleide Chaves Soares', nascimento: '22/10/1984' }];

    $scope.funcionario = {
        nome: 'Jefferson Pereira da Silva',
        sexo: 'M',
        cargo: 'Programador',
        salario: '1000.00',
        cep:'40250130',
        endereco: 'Rua São Roque',
        numero: '3',
        bairro: 'Cosme de Farias',
        email:'jefferson@webguirra.com',
        nascimento: '21/06/1983',
        cpf: '99999999999',
        rg: '9999',
        admissao: '01/01/2000',
        titulo_eleitor: '99999',
        zona: '999',
        secao: '999',
        telefone: '7134987077',
        celular: '7191952021',
        pai: 'Jose Lopes Guirra',
        mae: 'Raimunda Pereira da Silva',
        dependentes: [{ nome: 'Perla Chaves Soares da Silva', nascimento: '16/09/2007', tipo: 0, parentesco: 1 }, { nome: 'Mara Cleide Chaves Soares', nascimento: '22/10/1984', tipo: 0, parentesco: 1 }]
    };
    $scope.add = function () {
        $scope.funcionario.tipo = $scope.tipo;
        $scope.funcionario.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.funcionario.data = new Date();
        $scope.funcionario.tipo_requisicao = 'funcionario';
        requisicaoFactory.save($scope.funcionario);
    };

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
        alert($scope.dependente.nome);
        $modalInstance.close($scope.dependente);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
}