var app = angular.module("loginApp", ['ngResource']);
app.controller('userController', function ($scope, $window, userFactory) {
    $scope.user = { cnpj: '17320288000184', senha: 'jm2@@7', login: 'jefferson' };
    $scope.erro = '';
    $scope.signin = function () {
        userFactory.post($scope.user).$promise.then(function () {
            $scope.erro = '';
            $window.location.href += "home";
        }, function () {
            $scope.erro = 'Não foi possível efetuar o login. Verifique os dados informados e tente novamente.';
        });
    };
});