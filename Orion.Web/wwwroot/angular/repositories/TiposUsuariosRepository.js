(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.factory("TiposUsuariosRepository", ["TiposUsuariosService", TiposUsuariosRepository]);
    
    function TiposUsuariosRepository(TiposUsuariosService) {
        return {
            getAll: () => TiposUsuariosService.getAll(),
            add: tipoUsuario => TiposUsuariosService.add(tipoUsuario),
            delete: id => TiposUsuariosService.delete(id)
        }
    }
})();