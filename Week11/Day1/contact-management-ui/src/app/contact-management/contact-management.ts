import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Contact } from '../models/contact';

@Component({
  selector: 'app-contact-management',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './contact-management.html',
  styleUrl: './contact-management.css'
})
export class ContactManagement {

  contacts: Contact[] = [
    { contactId: 1, name: 'Rakesh', email: 'rakesh@gmail.com', phone: '9876543210', isActive: true },
    { contactId: 2, name: 'Rahul', email: 'rahul@gmail.com', phone: '9123456780', isActive: false },
    { contactId: 3, name: 'Priya', email: 'priya@gmail.com', phone: '9988776655', isActive: true }
  ];

}