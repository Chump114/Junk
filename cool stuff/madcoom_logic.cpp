/*

RNG ENGINE:
std::random_device rd;
std::mt19937 rng(rd());
INT DISTRIBUTION:
std::uniform_int_distribution<int> PDish(1, 100);
std::uniform_int_distribution<int> ADish(1, 4);

*/


if (madcoom) {
		int x = ADish(rng);
		int y = PDish(rng);
		switch (x) {
		case 1:
			coom0x = coom0x + y;
			break;
		case 2:
			coom0x = coom0x - y;
			break;
		case 3:
			coom0y = coom0y + y;
			break;
		case 4:
			coom0y = coom0y - y;
			break;
		}
		}
		
/*
Coom gon rabid with this logic
*/