//NVController.js
(function () {

    "use strict";
    
    angular.module("NVTapp",['ngAnimate','ngCookies'])
        .controller("NVController", ['$http','$cookies', nvController]);
    
    function nvController($http,$cookies) {

        var vm = this;
        var cookies = $cookies;
        vm.score = 0; //Score starts at 0
        vm.errorMessage = "";
        vm.isBusy = false;
        vm.Question = {
            questionNumber : 0,
            questionText : "",
            firstChoice : "",
            secondChoice: "",
            nvChoice: 1,
            isRelevant : true
        }

        setup();

        function setup() {
            cookies.remove('score');
        }
        vm.answeredQuestion = function (choice) {
            if(vm.Question.isRelevant == true)
            {
                if(vm.Question.nvChoice == choice)
                {
                    vm.score++; //We got a point!
                    cookies.put('score',vm.score);
                }
                else
                {
                    //You're violent, nothing happens
                }
                vm.nextQuestion();
            }
            else
            {
                vm.nextQuestion();
            }
        }

        vm.nextQuestion = function () {
            //Make httpget call here
            if (vm.Question.questionNumber < 65)
            {
                vm.isBusy = true;
                vm.Question.questionNumber++;
                $http.get("api/question/" + vm.Question.questionNumber)
                .then(function (response) {
                    //success
                    angular.copy(response.data, vm.Question);
                }, function (error) {
                    //failure
                    vm.errorMessage = "Failed to load question" + error;
                })
                .finally(function () {
                    vm.isBusy = false;
                });
            }
            else
            {
                //Test is over
                window.location = "/NVT/survey";
            }

        }

        vm.nextQuestion();

    }

})();