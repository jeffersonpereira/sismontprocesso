appModule.factory("requisicaoFactory", function ($http,$resource) {
    return $resource("/api/requisicao/:id", {}, {
        requisicoes: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        update: { method: 'PUT', params: { id: '@id' } },
        remove: { method: 'DELETE' }
    });
});