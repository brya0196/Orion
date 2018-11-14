(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.factory("TiposUsuariosRepository", ["TiposUsuariosService", TiposUsuariosRepository]);
    
    function TiposUsuariosRepository(TiposUsuariosService) {
        return {
            getAll: () => TiposUsuariosService.getAll(),
            getById: id => TiposUsuariosService.getById(id),
            add: tipoUsuario => TiposUsuariosService.add(tipoUsuario),
            delete: tipoUsuario => TiposUsuariosService.delete(tipoUsuario),
            update: tipoUsuario => TiposUsuariosService.update(tipoUsuario)
        }
    }
})();