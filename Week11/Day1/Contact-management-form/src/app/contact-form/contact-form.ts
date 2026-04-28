import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Contact } from '../models/contact';

@Component({
  selector: 'app-contact-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './contact-form.html',
  styleUrls: ['./contact-form.css']
})
export class ContactFormComponent {

  contacts: Contact[] = [];

  newContact: Contact = {
    contactId: 0,
    name: '',
    email: '',
    phone: '',
    isActive: false
  };

  addContact(form: any) {
    if (form.valid) {
      this.contacts.push({
        ...this.newContact,
        contactId: this.contacts.length + 1
      });

      form.resetForm();
    }
  }
}