(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.factory("UsuariosRepository", ["UsuariosService", UsuariosRepository]);

    function UsuariosRepository(UsuariosService) {
        return {
            getAll: () => UsuariosService.getAll(),
            getById: id => UsuariosService.getById(id),
            add: usuario => UsuariosService.add(usuario),
            delete: usuario => UsuariosService.delete(usuario),
            update: usuario => UsuariosService.update(usuario)
        }
    }
})();