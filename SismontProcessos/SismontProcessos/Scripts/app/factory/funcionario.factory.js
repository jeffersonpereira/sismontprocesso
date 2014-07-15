appModule.factory("funcionarioFactory", function ($resource) {
    return $resource("/api/funcionariovalue/:id", {}, {
        query: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        update: { method: 'PUT', params: { id: '@id' } },
        remove: { method: 'DELETE' }
    });
});