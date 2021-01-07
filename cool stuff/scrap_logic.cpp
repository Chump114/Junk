const short int init_coom0x = coom0x;
	const short int init_coom0y = coom0y;
	coom0x = boundx(coom0x, coom0w);
	if (coom0x != init_coom0x) {
		vel_coom0x = -vel_coom0x;
	}
	coom0y = boundy(coom0y, coom0h);
	if (coom0y != init_coom0y) {
		vel_coom0y = -vel_coom0y;
	}