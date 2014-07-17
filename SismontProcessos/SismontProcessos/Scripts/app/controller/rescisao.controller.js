var appModule = angular.module('rescisaoApp', ['ngResource', 'ngGrid', 'ui.bootstrap']);
appModule.controller('rescisaoController', function ($scope, $modal, requisicaoFactory, funcionarioFactory, assuntoFactory) {
    $scope.afastamentos =
        [
            { codigo: 10, descricao: 'Rescisão com justa causa por iniciativa do empregador' },
            { codigo: 11, descricao: 'Rescisão sem justa causa por iniciativa do empregador' },
            { codigo: 12, descricao: 'Termino do contrato de trabalho' },
            { codigo: 20, descricao: 'Rescisão com justa causa por iniciativa do empregado (rescisão indireta)' },
            { codigo: 21, descricao: 'Rescisão sem justa causa por iniciativa do empregado' },
            { codigo: 98, descricao: 'Outros' }
        ];
    $scope.avisos =
        [
            { codigo: 0, descricao: 'Sem Aviso' },
            { codigo: 1, descricao: 'Indenizado' },
            { codigo: 2, descricao: 'Trabalhado' }
        ];

    funcionarioFactory.query(function (data) {
        $scope.funcionarios = data;
    });

    assuntoFactory.query(function (data) {
        $scope.assuntos = data;
    });

    $scope.setAviso = function () {
        $scope.rescisao.aviso = $scope.aviso.descricao;
        $scope.codigo_aviso = $scope.aviso.codigo;
    };

    $scope.setAfastamento = function () {
        $scope.rescisao.afastamento = $scope.afastamento.descricao;
        $scope.afastamento.codigo_afastamento = $scope.afastamento.codigo;
    };

    $scope.openCalendar = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.opened = true;
    };


    $scope.rescisao = {tipo_requisicao:'rescisao'};
    $scope.add = function () {
        $scope.rescisao.tipo = $scope.tipo;
        $scope.rescisao.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.rescisao.data_afastamento = dateFormat($scope.rescisao.data_afastamento);
        requisicaoFactory.save($scope.rescisao).$promise.then(function () {
            $window.location.href += "Requisicao";
        });
    };

    /*Modal*/
    $scope.open = function () {
        var modalInstance = $modal.open({
            templateUrl: 'funcionario.html',
            controller: funcionarioController,
            resolve: {
                funcionarios: function () {
                    return $scope.funcionarios;
                }
            }
        });
        modalInstance.result.then(function (funcionario) {
            $scope.funcionario = funcionario;
            $scope.rescisao.funcionario_id = funcionario.funcionario_id;
        });
    }
});