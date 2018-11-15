(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.factory("TiposUsuariosRepository", ["TiposUsuariosService", TiposUsuariosRepository]);
    
    function TiposUsuariosRepository(TiposUsuariosService) {
        return {
            getAll: () => TiposUsuariosService.getAll(),
            getById: id => TiposUsuariosService.getById(id),
            add: tipoUsuario => TiposUsuariosService.add(tipoUsuario),
            delete: id => TiposUsuariosService.delete(id),
            update: tipoUsuario => TiposUsuariosService.update(tipoUsuario)
        }
    }
})();