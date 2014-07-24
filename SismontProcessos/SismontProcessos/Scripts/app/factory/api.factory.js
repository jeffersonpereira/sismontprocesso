var appModule = angular.module('app', ['ngResource', 'ngGrid', 'ui.bootstrap', 'angularFileUpload']);
appModule.factory("Api", function ($resource) {
    this.metodos = {
        query: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        upload: { method: 'POST' },
        update:{ method: 'PUT', params: { id: '@id' } },
        remove:{ method: 'DELETE' },
        };
    return {
        Requisicao: $resource('/api/requisicao/:id', {}, this.metodos),
        Assunto: $resource('/api/assunto/:id', {}, this.metodos),
        Usuario: $resource('/api/loginvalue/:id', {}, this.metodos),
        Rescisao: $resource('/api/rescisaovalue/:id', {}, this.metodos),
        Funcionario: $resource('/api/funcionariovalue/:id', {}, this.metodos),
        Documento: $resource('/api/documentovalue/:id', {}, this.metodos),
        Movimentacao: $resource('/api/movimentacaovalue/:id', {}, this.metodos)
    };
});