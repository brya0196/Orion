
(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.factory("VentasRepository", ["VentasService", VentasRepository]);

    function VentasRepository(VentasService) {
        return {
            getAll: () => VentasService.getAll(),
            getById: id => VentasService.getById(id),
            add: venta => VentasService.add(venta),
        }
    }
})();