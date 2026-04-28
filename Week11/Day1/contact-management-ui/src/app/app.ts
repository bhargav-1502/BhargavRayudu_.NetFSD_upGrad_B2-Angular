import { Component } from '@angular/core';
import { ContactManagement } from './contact-management/contact-management';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactManagement],
  template: `<app-contact-management></app-contact-management>`
})
export class App {
}