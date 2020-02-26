# Mirror-OnNetworkDestroy
Reproduction of a mirror bug (double invocation of OnNetworkDestroy)


Open SampleScene in Unity, start and press 'host', then spawn and kill a unit by pressing 's' and then 'd'. The OnNetworkDestroy() callback is called twice.

Tested with unity 2019.3.0f6, included is mirror 10.4.2