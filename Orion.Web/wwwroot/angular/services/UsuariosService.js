(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.service("UsuariosService", ["$http", "$q", "origin", UsuariosService]);

    function UsuariosService($http, $q, origin) {

        const getAllUsuarios = () => {
            let deferred = $q.defer();

            $http.get(origin + "/api/Usuarios/GetAll")
                .then(tiposUsuario => deferred.resolve(tiposUsuario.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        const getByIdUsuarios = id => {
            let deferred = $q.defer();

            $http.get(origin + "/api/Usuarios/GetById/" + id)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }

        const addUsuarios = usuario => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Usuarios/Add", usuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }

        const deleteUsuarios = usuario => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Usuarios/Delete", usuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        const updateUsuarios = usuario => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Usuarios/Update", usuario)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }

        return {
            getAll: getAllUsuarios,
            getById: getByIdUsuarios,
            add: addUsuarios,
            delete: deleteUsuarios,
            update: updateUsuarios
        };
    }
})();