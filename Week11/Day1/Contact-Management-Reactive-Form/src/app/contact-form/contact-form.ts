import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Contact } from '../contact';

@Component({
  selector: 'app-contact-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './contact-form.html',
  styleUrl: './contact-form.css'
})
export class ContactForm {

  contactForm: FormGroup;
  contacts: Contact[] = [];
  nextId: number = 1;

  constructor(private fb: FormBuilder) {
    this.contactForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      phone: ['', [Validators.required, Validators.minLength(10)]],
      isActive: [false]
    });
  }

  submitForm() {
    if (this.contactForm.valid) {

      const newContact: Contact = {
        contactId: this.nextId++,
        name: this.contactForm.value.name,
        email: this.contactForm.value.email,
        phone: this.contactForm.value.phone,
        isActive: this.contactForm.value.isActive
      };

      this.contacts.push(newContact);

      this.contactForm.reset({
        isActive: false
      });
    }
  }

}