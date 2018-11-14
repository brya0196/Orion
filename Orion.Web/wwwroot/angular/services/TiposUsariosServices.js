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

        const getByIdTipoUsuario = tipoUsuario => {
            let deferred = $q.defer();

            $http.get(origin + "/api/TiposUsuarios/GetById/" + id)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }
        
        const addTipoUsuario = tipoUsuario => {
            let deferred = $q.defer();
            
            $http.post(origin + "/api/TiposUsuarios/Add", tipoUsuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));   
            
            return deferred.promise;
        }
        
        const deleteTipoUsuario = tipoUsuario => {
            let deferred = $q.defer();
            
            $http.post(origin + "/api/TiposUsuarios/Delete", tipoUsuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));
            
            return deferred.promise;
        };

        const updateTipoUsuario = tipoUsuario => {
            let deferred = $q.defer();

            $http.post(origin + "/api/TiposUsuarios/Update", tipoUsuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }
        
        return {
            getAll: getAllTiposUsuarios, 
            getById: getByIdTipoUsuario,
            add: addTipoUsuario,
            delete: deleteTipoUsuario,
            update: updateTipoUsuario
        };
    }
})();