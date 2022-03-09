
const { assert } = require('chai');
let mathEnforcer = require('./Math-Enforcer');

it('Should return Undifined if the parameter in Addfunction is not a Number', () => {
    assert.isUndefined(mathEnforcer.addFive('5'));
    assert.isUndefined(mathEnforcer.addFive(function(){}));
});

it('Should return the correct sum when Addfunction is called', () => {
    assert.equal(mathEnforcer.addFive(5), 10);
    assert.equal(mathEnforcer.addFive(-1), 4);
    assert.equal(mathEnforcer.addFive(0), 5);
    assert.equal(mathEnforcer.addFive(3.5), 8.5);
});

it('Should return Undifined if the parameter in Subtractfunction is not a Number', () => {
    assert.isUndefined(mathEnforcer.subtractTen('5'));
    assert.isUndefined(mathEnforcer.subtractTen(function(){}));
});

it('Should return the correct sum when Subtractfunction is called', () => {
    assert.equal(mathEnforcer.subtractTen(50), 40);
    assert.equal(mathEnforcer.subtractTen(-1), -11);
    assert.equal(mathEnforcer.subtractTen(0), -10);
    assert.equal(mathEnforcer.subtractTen(11.5), 1.5);
});

it('Should return Undifined if a parameter in Sumfunction is not a Number', () => {
    assert.isUndefined(mathEnforcer.sum('5', 2));
    assert.isUndefined(mathEnforcer.sum(5, '2'));
    assert.isUndefined(mathEnforcer.sum(function(){}, 5));
});

it('Should return the correct sum when Sumfunction is called', () => {
    assert.equal(mathEnforcer.sum(50, 40), 90);
    assert.equal(mathEnforcer.sum(50, -50), 0);
    assert.equal(mathEnforcer.sum(50, 0), 50);
    assert.equal(mathEnforcer.sum(2.5, 2.5), 5);
});

