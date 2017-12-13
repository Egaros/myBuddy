# myBuddy
Purpose of this Xamarin form app is to provide a Android and iOS platform to a User to save his important notes, daily tasks. User can register himself on the platform and start saving and accessing his important notes. All data is locally saved on user device.

**This project exercises the following platforms, frameworks or features:**

- Xamarin.Android
- Xamarin.Forms
- XAML
- Bindings
- Triggers
- Sqlite Database
- Converters
- Central Styles
- Custom Renderers
- IoC
- Messaging Center
- Custom Controls
- Cross Plugins

**This project employs a few patterns listed below:**
- Enforces a ViewModel-per-Page concept
  - all ContentPage classes enforce a generic BaseViewModel type
  - automatically set as the binding context
- All tasks are proxied through a RunSafe method
