(function () {
    "use strict";
    
    const app = angular.module("app.orion");
    
    app.factory("StoreService", [StoreService]);
    
    function StoreService() {
        
        if(JSON.parse(localStorage.getItem("Data")).length > 0) 
            localStorage.setItem("Data", JSON.stringify({}));
        
        const Set = (key, value) => {
            let store = localStorage.getItem("Data");
            store = JSON.parse(store);
            store[key] = value
            localStorage.setItem("Data", JSON.stringify(store));
        };
        
        const Remove = (key) => {
            let store = localStorage.getItem("Data");
            store = JSON.parse(store);
            delete store[key]
            localStorage.setItem("Data", JSON.stringify(store));
        };
        
        const Find = key => {
            let store = localStorage.getItem("Data");
            store = JSON.parse(store);
            return store[key];
        };
        
        const GetAll = () => {
            let store = localStorage.getItem("Data");
            return JSON.parse(store);
        };
        
        return {
            Set: Set,
            Remove: Remove,
            Find: Find,
            GetAll: GetAll
        }
    }
    
})();