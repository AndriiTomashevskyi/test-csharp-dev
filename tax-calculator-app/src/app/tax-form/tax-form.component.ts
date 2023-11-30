import { Component } from '@angular/core';
import { TaxCalculatorService } from '../shared/tax-calculator.service';
import { HttpErrorResponse } from '@angular/common/http';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-tax-form',
  templateUrl: './tax-form.component.html',
  styleUrls: ['./tax-form.component.css']
})
export class TaxFormComponent {
  salary: number = 0;
  tax: number = 0;
  netAnnualSalary: number = 0;
  netMonthlySalary: number = 0;
  errorMessage: string = '';
  showResults: boolean = false;
  isLoading: boolean = false;

  taxForm = this.fb.group({
    salary: [0, [Validators.required, Validators.min(0)]]
  });

  constructor(private fb: FormBuilder, private taxCalculatorService: TaxCalculatorService) { }

  onSubmit() {
    if (this.taxForm.valid) {

      this.salary = this.taxForm.value.salary ?? 0;
      this.isLoading = true;
      this.showResults = false;
      this.errorMessage = '';

      this.taxCalculatorService.calculateTax(this.salary).subscribe(tax => {
        this.tax = tax;
        this.netAnnualSalary = this.salary - tax;
        this.netMonthlySalary = this.netAnnualSalary / 12;
        this.showResults = true;
        this.isLoading = false;
      },
        (error: HttpErrorResponse) => {
          this.errorMessage = 'Service is not available. Please try again later.';
          this.isLoading = false;
          this.showResults = false;
          console.error(error);
        }
      );
    }
  }

  onSalaryChange() {
    this.showResults = false;
    this.errorMessage = '';
  }
}
