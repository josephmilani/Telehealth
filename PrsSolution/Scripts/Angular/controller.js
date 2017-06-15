(function () {

    "use strict";

    angular.module("myApp")
        .controller("controller", controller);

    function controller($scope) {

        $scope.patients = [
            {
                'firstName': 'Brain',
                'lastName': 'Warren',
                'Address': 'Bangalore',
                'dbo': '12/4/17',
                'emergancyContact': '515484245'
            },
            {
                'firstName': 'Brain',
                'lastName': 'Warren',
                'Address': 'Bangalore',
                'dbo': '12/4/17',
                'emergancyContact': '515484245'
            },
            {
                'firstName': 'Brain',
                'lastName': 'Warren',
                'Address': 'Bangalore',
                'dbo': '12/4/17',
                'emergancyContact': '515484245'
            },
        ];
        $scope.addRow = function () {
            $scope.patients.push({ 'firstName': $scope.firstName, 'lastName': $scope.lastName, 'Address': $scope.Address, 'dbo': $scope.dbo, 'emergancyContact': $scope.emergancyContact });
            $scope.firstName = '';
            $scope.lastName = '';
            $scope.Address = '';
            $scope.dbo = '';
            $scope.emergancyContact = '';
        };
    }
})();