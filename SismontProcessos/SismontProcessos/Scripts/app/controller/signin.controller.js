appModule.controller('userController', function ($scope, $window, Api) {
    $scope.user = { cnpj: '17320288000184', senha: 'jm2@@7', login: 'jefferson' };
    $scope.signin = function () {
        Api.Usuario.post($scope.user).$promise.then(function () {
            Api.Notificacao('Sucesso', 'Seja bem vindo!.');
            $window.location.href += "home";
        }, function (erro) {
            Api.Notificacao('Erro', 'Infelizmente não conseguimos validar seus dados.');
        });
    };
});