(function () {
    'use strict';

    angular
        .module('NVTapp',['ngCookies'])
        .controller('resultsController', ['$http','$cookies',resultsController]);


    function resultsController($http,$cookies) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'resultsController';
        vm.isBusy = false;
        vm.newResult = {
            "age": 0,
            "gender": "",
            "score" : 0
        };
        vm.score = 0;
        var cookies = $cookies;
        vm.genderOptions = [
          { name: 'Male' },
          { name: 'Female' },
          { name: 'Non-Binary' },
          {name:'Transgender'}
        ];

        vm.mAvg = 0;
        vm.fAvg = 0;
        vm.nbAvg = 0;
        vm.trAvg = 0;
        vm.onlyNumbers = /^\d+$/;
        getResults();

        function getResults()
        {
            //Get score from cookie
            vm.score = cookies.get('score');
            vm.newResult.score = vm.score;
        }

        vm.skipSurvey = function()
        {
            window.location = '/NVT/results';
        }
        vm.addResult = function () {
            vm.isBusy = true;
            vm.newResult.gender = vm.newResult.gender.name;
            $http.post("/api/results", vm.newResult)
            .then(function (response) {
                //success
                console.log(vm.newResult);
                console.log(response.data);
                
            }, function () {
                //failure

            })
            .finally(function () {
                vm.isBusy = false;
                window.location = '/NVT/results';
            });
        }
        vm.maleRequest = { "gender": "Male" };
        vm.femaleRequest = {"gender" : "Female"}
        vm.nbRequest = {"gender":"Non-binary"}
        vm.transRequest = { "gender": "Transgender" };
        vm.getStats = function () {
            $http.post("/api/results/gender", vm.maleRequest )
            .then(function (response) {
                console.log(response.data);
                vm.mAvg = response.data;
            }, function() {

            });
            $http.post("/api/results/gender", vm.femaleRequest)
            .then(function (response) {
                vm.fAvg = response.data;
            }, function () {

            }); $http.post("/api/results/gender", vm.nbRequest)
            .then(function (response) {
                vm.nbAvg = response.data;
            }, function () {

            }); $http.post("/api/results/gender", vm.transRequest)
            .then(function (response) {
                vm.trAvg = response.data;
            }, function () {

            });
            
        }
        vm.getStats();
    }
})();
