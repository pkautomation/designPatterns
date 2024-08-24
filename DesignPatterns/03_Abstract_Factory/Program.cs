using _03_Abstract_Factory;

// so I go to the shop to get some weapon for self defence
MilitaryItemsFactory factory = new RealMilitaryItemsFactory();

// this gun looks nice, i want to try it!
var pistolInMyHands = factory.CreatePistol();
pistolInMyHands.Shoot();

// whats inside this medikit?
var medikit = factory.CreateMedikit();
medikit.Use();

// Daddy! Can I also have a gun ? 
// Sure son, let me get you one!

// leaving the shop and going for the toy shop

// ok, lets get you something son...

factory = new KidsMilitaryItemsFactory();
pistolInMyHands = factory.CreatePistol();
// let my try it daddy!
pistolInMyHands.Shoot();

// daddy I want a medikit too!
medikit = factory.CreateMedikit();
medikit.Use();
