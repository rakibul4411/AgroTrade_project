import { Component, OnInit } from '@angular/core';
import { LocaltradersdetailService } from 'src/app/shared/localtradersdetail.service';
import { ToastrService } from 'ngx-toastr';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-localtradersdetail',
  templateUrl: './localtradersdetail.component.html',
  styleUrls: ['./localtradersdetail.component.css']
})
export class LocaltradersdetailComponent implements OnInit {
  constructor(private service: LocaltradersdetailService,
    private toastr: ToastrService){ }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();
    this.service.formData = {
      Local_Trader_ID: null,
      Local_Trader_Name: '',
      Local_Buying_Price: null,
      Transportation_Cost: null,
      Storing_Cost: null,
      Total_Cost: null
    }
  }
  onSubmit(form: NgForm) {
    if (form.value.Local_Trader_ID == null)
      this.insertRecord(form);
   else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postLocalTradersDetails(form.value).subscribe(res => {
      this.toastr.success('Inserted successfully', 'ltd. Register');
      this.resetForm(form);
      this.service.refreshList();
    });
  }

  updateRecord(form: NgForm) {
    this.service.putLocalTradersDetails(form.value).subscribe(res => {
      this.toastr.info('Updated successfully', 'ltd. Register');
      this.resetForm(form);
      this.service.refreshList();
    }); 
  }
}
