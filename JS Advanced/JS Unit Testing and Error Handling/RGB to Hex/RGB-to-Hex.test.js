const { assert, expect } = require('chai');
const rgbToHexColor = require('./RGB-to-Hex');

it('Should return undifined if some of the parameters is not in the range', () => {
    assert.equal(rgbToHexColor(-1, 5, 255), undefined);
    assert.equal(rgbToHexColor(0, -1, 255), undefined);
    assert.equal(rgbToHexColor(255, 5, -1), undefined);

    assert.equal(rgbToHexColor(0, 5, 256), undefined);
    assert.equal(rgbToHexColor(0, 256, 255), undefined);
    assert.equal(rgbToHexColor(256, 5, 255), undefined);
});

it('Should return undifined if some of the parameters is not a numbers', () => {
    assert.equal(rgbToHexColor('1', 5, 255), undefined);
    assert.equal(rgbToHexColor(0, '5', 255), undefined);
    assert.equal(rgbToHexColor(255, 5, '2'), undefined);
});

it('Should returns proper hex represantations', () => {

    expect(rgbToHexColor(66, 135, 245)).to.equal('#4287F5');
    expect(rgbToHexColor(5, 10, 18)).to.equal('#050A12');
    expect(rgbToHexColor(79, 9, 23)).to.equal('#4F0917');

    expect(rgbToHexColor(255, 0, 0)).to.equal('#FF0000');
    expect(rgbToHexColor(0, 255, 0)).to.equal('#00FF00');
    expect(rgbToHexColor(0, 0, 255)).to.equal('#0000FF');

});
