appModule.controller("requisicaoController", function ($scope, $modal,Api) {

    Api.Requisicao.query(function (data) {
        $scope.requisicoes = data;
        
    });

    $scope.isdetail = false;
    $scope.getRequisicao = function (id,callback) {
            Api.Requisicao.query({ id: id }, function (data) {
            $scope.requisicao = data;
        });
    };

    $scope.getDocumento = function (id, callback) {
        Api.Documento.query({ id: id }, function (data) {
            $scope.documentos = data;
        });
    };

    $scope.update = function () {
        Api.Requisicao.update({ id: $scope.requisicao.requisicao_id }, $scope.requisicao);
    };

    $scope.edit = function () {
        $scope.isvisible = false;
    };

    /*Requisições*/
    this.columns =
        [
            { field: 'requisicao_id', displayName: '', width: 20, cellTemplate: '<div ng-show="row.getProperty(\'isdetail\')"><i ng-class="{\'fa fa-stop\' : row.entity.solucao==\'0\',\'fa fa-arrow-right\' : row.entity.solucao==\'1\'}" ></i></div>' },
            { field: 'data | date:dd/MM/yyyy', displayName: 'Data da Requisição', width: 150 },
            { field: 'descricao_tipo', displayName: 'Tipo', width: 150 },
            { field: 'assunto', displayName: 'Assunto', width: 150 },
            { field: 'solicitante', displayName: 'Solicitante', width: 150 },
            { field: 'prioridade_descricao', displayName: 'Prioridade', width: 150 },
            { field: 'vencimento | date:dd/MM/yyyy', displayName: 'Vencimento', width: 150 }
        ]

    $scope.showDetail = false;
    $scope.isvisible = false;
    $scope.gridRequisicao = {
        data: 'requisicoes| filter: search',
        columnDefs: this.columns,
        showGroupPanel: true,
        groupsCollapsedByDefault: true /*se usará agrupamento padrão*/,
        showColumnMenu:true,/*usuário seleciona os campos do grid*/
        multiSelect: false,
        beforeSelectionChange: function (row) {
            $scope.showDetail = row.entity.isdetail;
            $scope.requisicao = row.entity;
            $scope.getMovimentacao(row.entity.requisicao_id);
            $scope.isvisible = true;
        },
        i18n: 'pt-br',
        filterOptions: { filterText: '', useExternalFilter: true }

    };

    $scope.onGridDoubleClick = function (row) {
        var rowData = $scope.myData[row.rowIndex];
        alert("Double Clicked " + rowData)
    }

    /*Movimentação*/
    $scope.newMovimentacao = function () {
        var modalInstance = $modal.open({
            templateUrl: 'movimentacao.html',
            controller: function ($scope, $modalInstance) {
                $scope.ok = function () {
                    $modalInstance.close($scope.movimentacao);
                };
                $scope.cancel = function () {
                    $modalInstance.dismiss('cancel');
                };
            }
        });
        modalInstance.result.then(function (movimentacao) {
            Api.Movimentacao.save(movimentacao).$promise.then(function () {
                movimentacao = null;
            });
        });
    };

    this.columns2 =
        [
            { field: 'data', width: 120, displayName: 'Movimentação', cellFilter: 'date' },
            { field: 'solicitante', width: 250, displayName: 'Solcitante' },
            { field: 'anotacao', width: 500, displayName: 'Anotação' },
            { width: 100, cellTemplate: 'buttonAnexo.html' }
        ]

    $scope.gridMovimentacao = {
        data: 'movimentacoes',
        columnDefs: this.columns2,
        multiSelect: false,
        i18n: 'pt-br',

        beforeSelectionChange: function (row) {
            $scope.getDocumento(row.entity.anexo_id)
        }
    };

    $scope.getMovimentacao = function (id, callback) {
        Api.Movimentacao.query({ id: id }, function (data) {
            $scope.movimentacoes = data;
        });
    };
});
