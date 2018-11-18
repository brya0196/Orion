(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.service("ProductosService", ["$http", "$q", "origin", ProductosService]);

    function ProductosService($http, $q, origin) {

        const getAllProductos = () => {
            let deferred = $q.defer();

            $http.get(origin + "/api/Productos/GetAll")
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        const getByIdProductos = id => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Productos/GetById/" + id)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }

        const addProductos = productos => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Productos/Add", productos)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }

        const deleteProductos = productos => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Productos/Delete", productos)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        const updateProductos = productos => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Productos/Update", productos)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        }

        return {
            getAll: getAllProductos,
            getById: getByIdProductos,
            add: addProductos,
            delete: deleteProductos,
            update: updateProductos
        };
    }
})();