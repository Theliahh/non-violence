(function () {
    'use strict';

    angular
        .module('NVTapp')
        .controller('resultsController', resultsController);


    function resultsController($http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'resultsController';
        vm.isBusy = false;
        vm.newResult = {
            "age": 0,
            "gender": "",
            "score" : 0
        };
        vm.onlyNumbers = /^\d+$/;
        getResults();

        function getResults()
        {
            
        }

        vm.getScore = function () {
            //Get score from cookie
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
