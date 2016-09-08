function Binder($scope,
    _Factory,
    _Utility,$http) {
    $scope.Type = "Customer";
    $scope.Utility = _Utility;
    $scope.$watch("Type", function () {
        $scope.Model = _Factory.Create($scope.Type);
    });
    $scope.Models = [];
    $scope.Add = function () {
        $scope.Models.push($scope.Model);
        $scope.Model = _Factory.Create($scope.Type);
    }
    $scope.SaveToServer = function () {
        $http.post("http://localhost:60398/api/CustomerAction/", $scope.Models)
            .success(function (custs) {
                $scope.Models = custs;
                $scope.Errors = [];
                $scope.Model = _Factory.Create($scope.Type);
            }).error(function(errs){
                $scope.Errors=errs;
           
        });
    }
    
}