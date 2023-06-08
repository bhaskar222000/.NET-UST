Array.prototype.pairs = function (func) {
    for (var i = 0; i < this.length - 1; i++) {
        for (var j = i; j < this.length - 1; j++) {
            func([this[i], this[j+1]]);
        }
    }
}

var list = [1, 2, 3, 4,5,6];
list.pairs(function(pair){
    console.log(pair); // [1,2], [1,3], [2,3]
});