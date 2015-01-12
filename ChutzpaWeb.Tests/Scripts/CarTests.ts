///<reference path="qunit.d.ts"/>
///<reference path="../../ChutzpaWeb/scripts/car.ts"/>


QUnit.module("Car tests");

test("Can create a car", function () {
    // Arrange
    var car = new Car("big");
    
    strictEqual(car.engine, "big");
}); 