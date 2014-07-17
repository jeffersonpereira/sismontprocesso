var appModule = angular.module('feriasApp', ['ngResource', 'ngGrid', 'ui.bootstrap']);
appModule.controller('feriasController', function ($scope,$modal, requisicaoFactory, funcionarioFactory, assuntoFactory) {

    funcionarioFactory.query(function (data) {
        $scope.funcionarios = data;
    });

    assuntoFactory.query(function (data) {
        $scope.assuntos = data;
    });

    $scope.ferias = {};
    $scope.add = function () {
        $scope.ferias.tipo = $scope.tipo;
        $scope.ferias.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.ferias.tipo_requisicao = 'ferias';
        $scope.ferias.inicio_gozo = dateFormat($scope.ferias.inicio_gozo);
        $scope.ferias.fim_gozo = dateFormat($scope.ferias.fim_gozo);
        requisicaoFactory.save($scope.ferias).$promise.then(function () {
            $window.location.href += "Requisicao";
        });
    };

    $scope.openCalendar = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.opened = true;
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
            $scope.ferias.funcionario_id = funcionario.funcionario_id;
        });
    }
});

