appModule.factory("rescisaoFactory", function ($resource) {
    return $resource("/api/rescisaovalue/:id", {}, {
        query: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        update: { method: 'PUT', params: { id: '@id' } },
        remove: { method: 'DELETE' }
    });
});