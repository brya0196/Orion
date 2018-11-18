(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.factory("ProductosRepository", ["ProductosService", ProductosRepository]);

    function ProductosRepository(ProductosService) {
        return {
            getAll: () => ProductosService.getAll(),
            getById: id => ProductosService.getById(id),
            add: productos => ProductosService.add(productos),
            delete: productos => ProductosService.delete(productos),
            update: productos => ProductosService.update(productos)
        }
    }
})();