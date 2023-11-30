import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { TaxFormComponent } from "./tax-form/tax-form.component";
import { TaxCalculatorService } from "./shared/tax-calculator.service";
import { AppRoutingModule } from './app-routing.module';
import { NumberFormatPipe } from './shared/number-format.pipe';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    TaxFormComponent,
    NumberFormatPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [TaxCalculatorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
