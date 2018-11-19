(function(){
    "use strict";

    const app = angular.module("app.orion");

    app.service("VentasService", ["$http", "$q", "origin", VentasService]);

    function VentasService($http, $q, origin) {

        const getAllVentas = () => {
            let deferred = $q.defer();

            $http.get(origin + "/api/Ventas/GetAll")
                .then(tiposUsuario => deferred.resolve(tiposUsuario.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        const getByIdVentas = id => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Ventas/GetById/" + id)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        const addVentas = venta => {
            let deferred = $q.defer();

            $http.post(origin + "/api/Ventas/Add", venta)
                .then(response => deferred.resolve(response.data))
                .catch(err => deferred.reject(err));

            return deferred.promise;
        };

        return {
            getAll: getAllVentas,
            getById: getByIdVentas,
            add: addVentas
        };
    }
})();