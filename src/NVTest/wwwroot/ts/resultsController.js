(function () {
    'use strict';

    angular
        .module('app')
        .controller('resultsController', resultsController);


    function resultsController($http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'resultsController';
        vm.isBusy = false;
        vm.ages = [];
        getResults();

        function getResults()
        {
            vm.ages = [
                {}
            ]
        }

        vm.addResult = function () {
            vm.isBusy = true;

            $http.post("/api/results", vm.newResult)
            .then(function (response) {
                //success
                
            }, function () {
                //failure

            })
            .finally(function () {
                vm.isBusy = false;
            });
        }
    }
})();
