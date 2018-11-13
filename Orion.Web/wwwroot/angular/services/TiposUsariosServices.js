(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.service("TiposUsuariosService", ["$http", "$q", "origin", TiposUsuariosService]);
    
    function TiposUsuariosService($http, $q, origin) {
        
        const getAllTiposUsuarios = () => {
            let deferred = $q.defer();
            
            $http.get(origin + "/api/TiposUsuarios/GetAll")
                .then(tiposUsuario => deferred.resolve(tiposUsuario.data))
                .catch(err => deferred.reject(err));
            
            return deferred.promise;
        };
        
        const addTipoUsuario = tipoUsuario => {
            let deferred = $q.defer();
            
            $http.post(origin + "/api/TiposUsuarios/Add", tipoUsuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));   
            
            return deferred.promise;
        }
        
        const deleteTipoUsuario = id => {
            let deferred = $q.defer();
            
            $http.post(origin + "/api/TiposUsuarios/Delete", id)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));
            
            return deferred.promise;
        };
        
        return {
            getAll: getAllTiposUsuarios, 
            add: addTipoUsuario,
            delete: deleteTipoUsuario
        };
    }
})();