
using iVertion.Domain.Validation;

namespace iVertion.Domain.Entities
{
    public sealed class MedicalRecord : Entity
    {
        // Employee basic information
        public DateTime LastMedicalExamDate { get; private set; } // Date of the last medical exam
        public string? LastMedicalExamResult { get; private set; } // Result of the last medical exam
        public bool HasMedicalConditions { get; private set; }
        public string? MedicalConditions { get; private set; } // Known medical conditions of the employee
        public bool HasAllergies { get; private set; }
        public string? Allergies { get; private set; } // Known allergies of the employee
        public bool UsesMedications { get; private set; }
        public string? Medications { get; private set; } // Medications in use by the employee
        public string? EmergencyContactName { get; private set; } // Name of the emergency contact
        public string? EmergencyContactPhoneNumber { get; private set; } // Phone number of the emergency contact

        // Specific medical restrictions information
        public bool HasPhysicalRestrictions { get; private set; } // Indicates if the employee has physical restrictions
        public string? PhysicalRestrictionsDescription { get; private set; } // Description of the physical restrictions
        public bool HasMedicalLimitations { get; private set; } // Indicates if the employee has medical limitations
        public string? MedicalLimitationsDescription { get; private set; } // Description of the medical limitations

        // Other relevant information
        public string? Notes { get; private set; } // Additional notes or observations

        // Habits information
        public bool UsesTobacco { get; private set; } // Indicates if the employee uses tobacco
        public bool UsesAlcohol { get; private set; } // Indicates if the employee consumes alcohol
        public bool UsesDrugs { get; private set; } // Indicates if the employee uses drugs

        // Blood type information
        public string? BloodType { get; private set; } // Employee's blood type

        // Organ donor status
        public bool IsOrganDonor { get; private set; } // Indicates if the employee is an organ donor

        // Additional information
        public string? MedicalHistory { get; private set; } // Medical history including surgeries and chronic diseases
        public string? VaccinationHistory { get; private set; } // History of vaccinations received by the employee
        public string? ComplementaryExams { get; private set; } // Record of complementary exams (laboratory, imaging, etc.)
        public string? WorkAccidentHistory { get; private set; } // History of work accidents, injuries, and treatments
        public string? ErgonomicAssessment { get; private set; } // Results of ergonomic assessments and recommendations
        public string? PsychosocialAssessment { get; private set; } // Psychosocial assessments, stress levels, and mental health support
        public string? MedicalContacts { get; private set; } // Contacts of medical professionals responsible for the employee's care
        public string? DietaryHabits { get; private set; } // Information about dietary habits and physical activity
        public string? AnthropometricMeasurements { get; private set; } // Anthropometric measurements (weight, height, BMI, etc.)
        public string? OccupationalRiskAssessment { get; private set; } // Assessment of occupational risks and preventive measures
        public string? HealthAndSafetyTraining { get; private set; } // Records of health and safety training completed by the employee

        // Relationship with the Employee entity
        public int EmployeeId { get; private set; } 
        public Employee? Employee { get; set; }

        private void ValidationDomain(DateTime lastMedicalExamDate,
                                      string lastMedicalExamResult,
                                      bool hasMedicalConditions,
                                      string? medicalConditions,
                                      bool hasAllergies,
                                      string? allergies,
                                      bool usesMedications,
                                      string? medications,
                                      string emergencyContactName,
                                      string emergencyContactPhoneNumber,
                                      bool hasPhysicalRestrictions,
                                      string? physicalRestrictionsDescription,
                                      bool hasMedicalLimitations,
                                      string? medicalLimitationsDescription,
                                      string? notes,
                                      string bloodType,
                                      string? medicalHistory,
                                      string? vaccinationHistory,
                                      string? complementaryExams,
                                      string? workAccidentHistory,
                                      string? ergonomicAssessment,
                                      string? psychosocialAssessment,
                                      string? medicalContacts,
                                      string? dietaryHabits,
                                      string? anthropometricMeasurements,
                                      string? occupationalRiskAssessment,
                                      string? healthAndSafetyTraining)
        {
            DomainExceptionValidation.When(lastMedicalExamDate == default,
                                            "Invalid Last Medical Exam Date, must be specified.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(lastMedicalExamResult),
                                           "Invalid Last Medical Exam Result, must not be null or empty.");
            DomainExceptionValidation.When(lastMedicalExamResult.Length < 1 || lastMedicalExamResult.Length > 255,
                                            "Invalid Last Medical Exam Result length, must be between 1 and 255 characters.");
            if(hasMedicalConditions){
                DomainExceptionValidation.When(String.IsNullOrEmpty(medicalConditions),
                                               "Invalid Medical Conditions, must not be null or empty.");
                DomainExceptionValidation.When(medicalConditions?.Length > 255,
                                                "Invalid Medical Conditions length, maximum 255 characters allowed.");
            }
            if(hasAllergies){
                DomainExceptionValidation.When(String.IsNullOrEmpty(allergies),
                                               "Invalid Allergies, must not be null or empty.");
                DomainExceptionValidation.When(allergies?.Length > 255,
                                                "Invalid Allergies length, maximum 255 characters allowed.");
            }
            if(usesMedications){
                DomainExceptionValidation.When(String.IsNullOrEmpty(medications),
                                               "Invalid Medications, must not be null or empty.");
                DomainExceptionValidation.When(medications?.Length > 255,
                                                "Invalid Medications length, maximum 255 characters allowed.");
            }
            DomainExceptionValidation.When(emergencyContactName?.Length < 1 || emergencyContactName?.Length > 255,
                                            "Invalid Emergency Contact Name length, must be between 1 and 255 characters.");
            DomainExceptionValidation.When(emergencyContactPhoneNumber?.Length < 1 || emergencyContactPhoneNumber?.Length > 20,
                                            "Invalid Emergency Contact Phone Number length, must be between 1 and 20 characters.");
            DomainExceptionValidation.When(hasPhysicalRestrictions && (physicalRestrictionsDescription?.Length < 1 || physicalRestrictionsDescription?.Length > 255),
                                            "Invalid Physical Restrictions Description length, must be between 1 and 255 characters.");
            DomainExceptionValidation.When(hasMedicalLimitations && (medicalLimitationsDescription?.Length < 1 || medicalLimitationsDescription?.Length > 255),
                                            "Invalid Medical Limitations Description length, must be between 1 and 255 characters.");
            DomainExceptionValidation.When(notes?.Length > 1000,
                                            "Invalid Notes length, maximum 1000 characters allowed.");
            DomainExceptionValidation.When(String.IsNullOrEmpty(bloodType),
                                            "Blood Type is required.");
            DomainExceptionValidation.When(bloodType?.Length < 1 || bloodType?.Length > 5,
                                            "Invalid Blood Type length, must be between 1 and 5 characters.");
            DomainExceptionValidation.When(medicalHistory?.Length > 255,
                                            "Invalid Medical History length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(vaccinationHistory?.Length > 255,
                                            "Invalid Vaccination History length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(complementaryExams?.Length > 255,
                                            "Invalid Complementary Exams length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(workAccidentHistory?.Length > 255,
                                            "Invalid Work Accident History length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(ergonomicAssessment?.Length > 255,
                                            "Invalid Ergonomic Assessment length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(psychosocialAssessment?.Length > 255,
                                            "Invalid Psychosocial Assessment length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(medicalContacts?.Length > 255,
                                            "Invalid Medical Contacts length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(dietaryHabits?.Length > 255,
                                            "Invalid Dietary Habits length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(anthropometricMeasurements?.Length > 255,
                                            "Invalid Anthropometric Measurements length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(occupationalRiskAssessment?.Length > 255,
                                            "Invalid Occupational Risk Assessment length, maximum 255 characters allowed.");
            DomainExceptionValidation.When(healthAndSafetyTraining?.Length > 255,
                                            "Invalid Health and Safety Training length, maximum 255 characters allowed.");
            LastMedicalExamDate             = lastMedicalExamDate;
            LastMedicalExamResult           = lastMedicalExamResult;
            HasMedicalConditions            = hasMedicalConditions;
            MedicalConditions               = medicalConditions;
            HasAllergies                    = hasAllergies;
            Allergies                       = allergies;
            UsesMedications                 = usesMedications;
            Medications                     = medications;
            EmergencyContactName            = emergencyContactName;
            EmergencyContactPhoneNumber     = emergencyContactPhoneNumber;
            HasPhysicalRestrictions         = hasPhysicalRestrictions;
            PhysicalRestrictionsDescription = physicalRestrictionsDescription;
            HasMedicalLimitations           = hasMedicalLimitations;
            MedicalLimitationsDescription   = medicalLimitationsDescription;
            Notes                           = notes;
            BloodType                       = bloodType;
            MedicalHistory                  = medicalHistory;
            VaccinationHistory              = vaccinationHistory;
            ComplementaryExams              = complementaryExams;
            WorkAccidentHistory             = workAccidentHistory;
            ErgonomicAssessment             = ergonomicAssessment;
            PsychosocialAssessment          = psychosocialAssessment;
            MedicalContacts                 = medicalContacts;
            DietaryHabits                   = dietaryHabits;
            AnthropometricMeasurements      = anthropometricMeasurements;
            OccupationalRiskAssessment      = occupationalRiskAssessment;
            HealthAndSafetyTraining         = healthAndSafetyTraining;
        }
    }
}
