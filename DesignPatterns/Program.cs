// VideoStorage videoStorage = new VideoStorage(new CompressorMP4(), new OverlayBlackAndWhile());

// videoStorage.Store("./videos");
// videoStorage.SetCompressor(new CompressorWOV());

// videoStorage.Store("./videos");

// ShoppingList shoppingList = new();

// shoppingList.Push("3 Eggs");
// shoppingList.Push("1 Chicken");
// shoppingList.Push("1L Milk");

// var iterator = shoppingList.CreateIterator();

// while(iterator.HasNext())
// {
//     Console.WriteLine(iterator.Current());
//     iterator.Next();
// }


// Command Pattern

Light light = new Light();

RemoteControl remoteControl = new(new LightOnCommand(light));

remoteControl.PressButton();

remoteControl.SetCommand(new LightOffCommand(light));

remoteControl.PressButton();
