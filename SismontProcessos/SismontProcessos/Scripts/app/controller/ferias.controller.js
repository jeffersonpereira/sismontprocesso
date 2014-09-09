appModule.controller('feriasController', function ($scope,$modal,Api) {

    Api.Funcionario.query(function (data) {
        $scope.funcionarios = data;
    });

    Api.Usuario.query(function (data) {
        $scope.usuarios = data;
    });
    Api.Assunto.query(function (data) {
        $scope.assuntos = data;
    })
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

    $scope.requisicao = {};
    $scope.add = function () {
        $scope.requisicao.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.requisicao.tipo_requisicao = 'ferias';
        $scope.requisicao.inicio_gozo = dateFormat($scope.requisicao.inicio_gozo);
        $scope.requisicao.fim_gozo = dateFormat($scope.requisicao.fim_gozo);
        $scope.requisicao.recursos = $scope.logins;
        Api.Requisicao.save($scope.requisicao).$promise.then(function () {
            Api.Notificacao('Sucesso', 'Requisição adicionada com sucesso.');
            $scope.requisicao = null;
        }, function (erro) {
            Api.Notificacao('Erro', erro);
        });
    };

    $scope.openCalendar = function ($event,buttonId) {
        $event.preventDefault();
        $event.stopPropagation();
        if (buttonId == 1) {
            $scope.opened1 = true;
        }
        else {
            $scope.opened2 = true;
        }
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
            $scope.requisicao.funcionario_id = funcionario.funcionario_id;
        });
    }
});

