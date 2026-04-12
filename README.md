Requirments for A04:

Login Screen:
  Fields for Email and Password.
  "Forgot Password" and "Register" links.
  Validation feedback for incorrect credentials.

Registration Screen:
  Account Details: Name, Email, Password (with confirmation).
  Residence Details: Address field and a dropdown for "Type of Residence" (e.g., Apartment, House, Studio).
  Requirement Check: Ensure the "Submit" button is disabled until all compulsory fields are filled.

Home Dashboard:
  Search & Filter Bar:
  Search: Input field for searching items by name.
  Filter/Sort: Dropdowns for Category, Value Range (Min/Max), and Sort Order (High-to-Low, Low-to-High).

Item List/Grid:
Items must be grouped by category (e.g., "Electronics" header followed by its items).
Each item card should display: Name, Category, and Value.

Item Management (CRUD):
  Add/Edit Item Modal or Page:
  Form fields for Name, Category (dropdown), Value (numeric input), and Description (multi-line text area).
  "Save" and "Cancel" buttons.

Item Detail View:
    Expanded view of an item’s details (especially the optional Description).
    Direct "Edit" and "Delete" icons.
    Delete Confirmation: A simple pop-up/modal to confirm deletion ("Are you sure you want to delete this item?") to prevent accidental data loss.

Profile & Account Settings:
  Residence Section: * Editable fields for Address and Residence Type.
  Account Security: * Option to change password.

Performance/Scalability
  System should be able to handle multiple users simultaneously
