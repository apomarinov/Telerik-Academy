function asd (){
	throw new Error('asd');
}

function bsd(){
	asd();
	console.log('AAAAAAAAAAAAAAAAAAAAAAAAA');
}

bsd();
