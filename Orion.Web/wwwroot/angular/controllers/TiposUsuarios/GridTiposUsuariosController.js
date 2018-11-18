(function(){
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.controller("GridTiposUsuariosController", ["$scope", "StoreService", "TiposUsuariosRepository", GridTiposUsuariosController]);
    
    function GridTiposUsuariosController($scope, StoreService, TiposUsuariosRepository) {
        
        var vm = this;
        
        vm.TiposUsuarios = [];
        populateGrid();
        
        vm.delete = id => {
            TiposUsuariosRepository.delete(id)
                .then(response => {
                    alert("Eliminado");
                    vm.TiposUsuarios = [];
                    populateGrid();
                })
                .catch(err => console.log(err));
        };
        
        vm.update = id => {
            StoreService.Set("updateTipoUsuario", id);
            window.location.href = "/Home/UpdateTiposUsuarios";
        };
        
        function populateGrid() {
            TiposUsuariosRepository.getAll()
                .then(tiposUsuario => vm.TiposUsuarios = tiposUsuario.value)
                .catch(err => console.log(err));
        }
    }
    
})();