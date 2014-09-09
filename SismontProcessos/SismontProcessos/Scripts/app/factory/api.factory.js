var appModule = angular.module('app', ['ngResource', 'ngGrid', 'ui.bootstrap', 'angularFileUpload', 'toaster', 'ngAnimate']);
appModule.factory("Api", function ($resource, toaster) {
    this.metodos = {
        query: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        upload: { method: 'POST' },
        update:{ method: 'PUT', params: { id: '@id' } },
        remove:{ method: 'DELETE' },
        };
    return {
        Requisicao: $resource('/api/requisicao/:id', {}, this.metodos),
        Assunto: $resource('/api/assunto/:id', {}, { query: { method: 'GET', params: { id: '' }, isArray: true }, getByDescricao: { method: 'GET', params: { descricao: '' }, isArray: true } }),
        Usuario: $resource('/api/loginvalue/:id', {}, this.metodos),
        Rescisao: $resource('/api/rescisaovalue/:id', {}, this.metodos),
        Funcionario: $resource('/api/funcionariovalue/:id', {}, this.metodos),
        Documento: $resource('/api/documentovalue/:id', {}, this.metodos),
        Cargo: $resource('/api/cargovalue/:id', {}, this.metodos),
        GrauInstrucao: $resource('/api/grauinstrucaovalue/:id', {}, this.metodos),
        Movimentacao: $resource('/api/movimentacaovalue/:id',
            {},
            {
                getById: { method: 'GET', params: { id: '' }, isArray: true },
                getUrl: { method: 'GET', params: { anexoid: '' }, isArray: false },
                upload: { method: 'POST' },
            }),
        Notificacao: function (titulo,texto) {
            toaster.pop('note', titulo, texto);
        }
    };
});