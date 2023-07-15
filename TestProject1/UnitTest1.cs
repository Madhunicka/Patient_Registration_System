using FluentAssertions;
using FluentAssertions.Equivalency;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Patient_Registration_System;
using Patient_Registration_System.Views;

namespace TestProject1

{
    public class UnitTest1
    {
        [Fact]
        public void CalculateTotalAmount_ShouldReturnCorrectTotalAmount()
        {
            // Arrange
            var bill = new Bill
            {
                DoctorCharge = 100.0,
                ServiceCharges = 20.0,
                AdditionalCharge = 10.0,
                MedicationCost = 30.0,
                LabTests = 15.0
            };

            var billCalculator = new BillCalculator();

            // Act
            double totalAmount = billCalculator.CalculateTotalAmount(bill);

            // Assert
            Assert.Equal(175.0, totalAmount);
        }

        [Fact]
        public void CalculateTotalAmount_ShouldThrowExceptionForNullBill()
        {
            // Arrange
            var billCalculator = new BillCalculator();

            Assert.Throws<ArgumentNullException>(() => billCalculator.CalculateTotalAmount(null));
        }
        public class BillCalculator
        {
            public double CalculateTotalAmount(Bill selectedBill)
            {
                if (selectedBill == null)
                {
                    throw new ArgumentNullException(nameof(selectedBill), "Please select a person to calculate the bill.");
                }

                double totalAmount = selectedBill.DoctorCharge + selectedBill.ServiceCharges +
                    selectedBill.AdditionalCharge + selectedBill.MedicationCost + selectedBill.LabTests;

                return totalAmount;
            }
        }
    }
}