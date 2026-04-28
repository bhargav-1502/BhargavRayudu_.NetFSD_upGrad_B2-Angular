import { Component } from '@angular/core';
import { ContactForm } from './contact-form/contact-form';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}