appModule.controller('rescisaoController', function ($scope, $modal, Api) {
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

    Api.Funcionario.query(function (data) {
        $scope.funcionarios = data;
    });

    Api.Assunto.query(function (data) {
        $scope.assuntos = data;
    });

    Api.Usuario.query(function (data) {
        $scope.usuarios = data;
    });

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

    $scope.setAviso = function () {
        $scope.requisicao.aviso = $scope.aviso.descricao;
        $scope.requisicao.codigo_aviso = $scope.aviso.codigo;
    };

    $scope.setAfastamento = function () {
        $scope.requisicao.afastamento = $scope.afastamento.descricao;
        $scope.requisicao.codigo_afastamento = $scope.afastamento.codigo;
    };

    $scope.openCalendar = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.opened = true;
    };


    $scope.requisicao = { tipo_requisicao: 'rescisao' };
    $scope.add = function () {
        $scope.requisicao.assunto_requisicao_id = $scope.assunto.assunto_requisicao_id;
        $scope.requisicao.data_afastamento = dateFormat($scope.requisicao.data_afastamento);
        $scope.requisicao.recursos = $scope.logins;
        Api.Requisicao.save($scope.requisicao).$promise.then(function () {
            Api.Notificacao('Sucesso', 'Requisição adicionada com sucesso.');
            $scope.requisicao = null;
        }, function (erro) {
            Api.Notificacao('Erro', erro);
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
            $scope.requisicao.funcionario_id = funcionario.funcionario_id;
        });
    }
});