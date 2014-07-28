appModule.controller("requisicaoController", function ($scope, $modal,Api) {

    Api.Requisicao.query(function (data) {
        $scope.requisicoes = data;
        
    });

    $scope.isdetail = false;
    $scope.getRequisicaoById = function (id,callback) {
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
        canSelectRows: true,
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
    }


    $scope.movimentacao = {arquivo:''};
    /*Movimentação*/

    $scope.anexoDownload = function (anexo_id) {
        Api.Movimentacao.getUrl({ anexoid: anexo_id }, function (data) {
            window.open(data.url_download, '_blank', '');
        });
        
    };

    $scope.newMovimentacao = function () {
        var modalInstance = $modal.open({
            templateUrl: 'movimentacao.html',
            controller: movimentacaoController,
            resolve: {
                movimentacao: function () {
                    return $scope.movimentacao;
                }
            }
        });
        modalInstance.result.then(function (movimentacao) {
            Api.Requisicao.update({id:$scope.requisicao.requisicao_id},movimentacao).$promise.then(function () {
                $scope.getMovimentacao($scope.requisicao.requisicao_id);
            });
        });
    };
    this.columns2 =
        [
            { field: 'data', width: 120, displayName: 'Movimentação', cellFilter: 'date' },
            { field: 'solicitante', width: 250, displayName: 'Solcitante' },
            { field: 'anotacao', width: 500, displayName: 'Anotação' },
            { field: 'isanexo', displayName: '', width: 100, cellTemplate: 'buttonAnexo.html' }
        ]

    $scope.gridMovimentacao = {
        data: 'movimentacoes',
        columnDefs: this.columns2,
        canSelectRows: true,
        multiSelect: false,
        i18n: 'pt-br',
        beforeSelectionChange: function (row) {
            $scope.getDocumento(row.entity.anexo_id)
        }
    };

    $scope.getMovimentacao = function (id, callback) {
        Api.Movimentacao.getById({ id: id }, function (data) {
            $scope.movimentacoes = data;
        });
    };
});

var movimentacaoController = function ($scope, $modalInstance, $http, $timeout, $upload, movimentacao) {

    $scope.movimentacao = movimentacao;
    $scope.ok = function () {
        $modalInstance.close($scope.movimentacao);
    };
    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
    $scope.upload=[];
    $scope.onFileSelect = function ($files) {
        for (var i = 0; i < $files.length; i++) {
            var $file = $files[i];
            (function (index) {
                $scope.upload[index] = $upload.upload({
                    url: "./api/movimentacaovalue",
                    method: "POST",
                    file: $file
                }).success(function (data, status, headers, config) {
                    $scope.movimentacao.arquivo = data.uploadFile;
                }).error(function (data, status, headers, config) {
                    // file failed to upload
                    console.log(data);
                });
            })(i);
        }
    }

    $scope.abortUpload = function (index) {
        $scope.upload[index].abort();
    }
};
