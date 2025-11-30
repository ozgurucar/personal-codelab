VideoStorage videoStorage = new VideoStorage(new CompressorMP4(), new OverlayBlackAndWhile());

videoStorage.Store("./videos");
videoStorage.SetCompressor(new CompressorWOV());

videoStorage.Store("./videos");