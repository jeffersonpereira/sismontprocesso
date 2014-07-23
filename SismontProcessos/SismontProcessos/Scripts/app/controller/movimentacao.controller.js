appModule.controller("movimentacaoController", function ($scope, Api) {

    $scope.getRequisicao = function (id, callback) {
        Api.Movimentacao.query({ id: id }, function (data) {
            $scope.requisicao = data;
        });
    };

    $scope.update = function () {
        Api.Requisicao.update({ id: $scope.requisicao.requisicao_id }, $scope.requisicao);
    };
});