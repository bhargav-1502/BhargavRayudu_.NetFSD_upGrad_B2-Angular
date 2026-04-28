import { Component } from '@angular/core';
import { ContactFormComponent } from './contact-form/contact-form';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ContactFormComponent],
  templateUrl: './app.html'
})
export class App {}