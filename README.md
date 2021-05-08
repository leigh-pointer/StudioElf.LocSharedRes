# StudioElf.LocSharedRes
Example: How to create Localised Module for Oqtane.  This solution also uses a SharedResource.resx for shared language resources.

The solutions is set up to run standalone.  This is done by adding the Oqtane.Server project to the solution. 

The localization is minimal but enough to see how the SharedResources is impletmented.
When the module is built for Debug the module dll and the language resource are copied to the relative folders.
When the module is built for Release two packages are created; one for the module the other for the Localization (

For this module example I chose Dutch (nl-NL) and will be needed to be setup in you Oqtane instance.
