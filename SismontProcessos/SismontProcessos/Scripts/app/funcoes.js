var dateFormat = function (date) {
    ano = date.getFullYear();
    mes = date.getMonth() + 1;
    dia = date.getDate();
    if (mes < 10) {
        mes = "0" + mes;
    }
    if (dia < 10) {
        dia = "0" + dia;
    }
    alert(mes);
    return dia + '/' + mes + '/' + ano;
}


var funcionarioController = function ($scope, $modalInstance, funcionarios) {
    $scope.funcionarios = funcionarios;
    this.columns =
        [
            { field: 'matricula', width: 120, displayName: 'Matricula' },
            { field: 'nome', width: 250, displayName: 'Nome' }
        ]

    $scope.gridFuncionario = {
        data: 'funcionarios | filter: search',
        columnDefs: this.columns,
        showFooter: true,
        multiSelect: false,
        i18n: 'pt-br',
        beforeSelectionChange: function (row) {
            $scope.funcionario = row.entity;
        }
    };

    $scope.ok = function () {
        $modalInstance.close($scope.funcionario);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss();
    };
};