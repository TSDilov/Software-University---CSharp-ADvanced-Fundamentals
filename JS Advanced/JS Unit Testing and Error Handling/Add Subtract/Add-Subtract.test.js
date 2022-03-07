const { assert, expect } = require('chai');
const { it } = require('mocha');
let createCalculator = require('./Add-Subtract');

it('Should return object when we call the function', () => {
    
    assert.equal(typeof createCalculator(), 'object');
});

it('Should return object that contains the add, subtract and get properties', () => {
    let calc = createCalculator();
    expect(calc).haveOwnProperty('add');
    expect(calc).haveOwnProperty('subtract');
    expect(calc).haveOwnProperty('get');
});

it('Should gets the correct value', () => {
    let calc = createCalculator();
    assert.equal(calc.get(), 0);
});

it('Should adds sum properly', () => {
    let calc = createCalculator();
    calc.add(3);
    calc.add(5);
    assert.equal(calc.get(), 8);
});

it('Should subtracts sum properly', () => {
    let calc = createCalculator();
    calc.add(3);
    calc.add(5);
    calc.subtract(2);
    assert.equal(calc.get(), 6);
});

it('Should calculates properly if the number is represented like a string', () => {
    let calc = createCalculator();
    calc.add('3');
    calc.add('5');
    calc.subtract('2');
    assert.equal(calc.get(), 6);
});

it('Should return Nan if the string does not represent a number', () =>{
    let calc = createCalculator();
    calc.add('SoftUni');
    assert.isNaN(calc.get());
});